using BackendHamster.Object;
using BackendHamster.Ticker;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackendHamster.Operations
{
    public class cageManagement
    {
        static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1, 1);
        public async void TickEvent(object sender, TickEventArgs e)
        {
             await Motionering();                
        }
        /// <summary>
        /// Lägger in hamstrar i burar, detta ska ske i början på varje dag 
        /// </summary>
        public void HamstersToCage()
        {
            using (var dbContext = new DbContextHamster())
            {
                List<Hamster> hamsterList = dbContext.hamsters.OrderBy(x => x.gender).ToList();
                foreach (var item in dbContext.cages)
                {
                    if(dbContext.cageBuddies.Count() == 0 && dbContext.motionsBatch.Count() == 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            var logg = new AktivityLogg();
                            logg.timeLogg = DateTime.Now;
                            logg.hamsterLogg = hamsterList.First();
                            logg.aktivitet = Aktivities.aktivities.dagbur;
                            dbContext.logg.Add(logg);

                            var buddie = new CageBuddies(hamsterList.First(), item);
                            dbContext.cageBuddies.Add(buddie);
                            hamsterList.RemoveAt(0);

                        }
                        foreach (var n in dbContext.cageBuddies)
                        {

                            n.cageHamster.inCheck = DateTime.Now;
                        }
                    }

                }

                dbContext.SaveChanges();

            }
        }
        /// <summary>
        /// Hittar dom som har väntat längst på motion och skickar dom till motionsburen 
        /// </summary>
        public List<Hamster> MoveToMotion()
        {

            using (var dbContext = new DbContextHamster())
            {
                var hamsters = MotionSorted().ToList();
                var feamaleList = hamsters.Where(n => n.gender == Hamster.Gender.Feamale).ToList();
                var maleList = hamsters.Where(n => n.gender == Hamster.Gender.Male).ToList();

                var sendToMotion = maleList.First().senastMotioneradTid < feamaleList.First().senastMotioneradTid ?
                        maleList.GetRange(0, 6) : feamaleList.GetRange(0, 6);
                return sendToMotion;              
            }
        }
        public CageBuddies FindCageBuddie(Hamster hamster)
        {
            using(var dbContext = new DbContextHamster())
            {               
                var tempBuddy = dbContext.cageBuddies;
                 foreach (var item in tempBuddy)
                {
                    if(item.cageHamster.name == hamster.name)
                    {
                        return item;
                    }
                }
                return null;
            }

        }
        public async Task Motionering()
        {

            string message = "";
            using (var dbContext = new DbContextHamster())
            {
                var tempList = new List<Hamster>();
                var buddiesTemp = dbContext.motionsBatch;

                var tid = dbContext.motionsyta.First().motionTid;
                if(tid == 10)
                {
                    foreach (var item in buddiesTemp)
                    {                        
                        tempList.Add(item.activeHamster);
                        item.activeHamster.senastMotioneradTid = DateTime.Now;
                        dbContext.motionsBatch.Remove(item);
                    }
                    foreach (var item in tempList)
                    {
                        //var logg = new AktivityLogg();
                        //logg.timeLogg = DateTime.Now;
                        //logg.hamsterLogg = item;
                        //logg.aktivitet = Aktivities.aktivities.dagbur;
                        //dbContext.logg.Add(logg);
                        message += ($"{item.name} lämnade motionsburen \n");
                        FindCage(item);
                    }
                    tid = 0;
                }
                if (tid == 0)
                {
                    var motionLista = MoveToMotion();
                    SqlConnection conn = new SqlConnection(
                            @"Server=LAPTOP-6GH4TEP5\SQLEXPRESS;Database=advBjornEklund;Trusted_Connection=True;MultipleActiveResultSets=true");
                    SqlDataReader rdr = null;
                    try
                    {
                    
                    using (conn)
                        {
                        conn.Open();
                            message += "\n";
                            message += "\n";
                            foreach (var item in  motionLista)
                            {
                                message += $"{item.name} har börjat motionera \n";
                                string query = $"INSERT INTO motionsBatch " +
                                               $"VALUES({item.ID}, 1)";
                                SqlCommand cmd = new SqlCommand(query,conn);
                            rdr = cmd.ExecuteReader();
                            while(rdr.Read())
                            {

                            }

                            }
                            conn.Close();    
                    }
                        }
                    catch { };
                    foreach (var item in motionLista)
                    {
                        //var logg = new AktivityLogg();
                        //logg.timeLogg = DateTime.Now;
                        //logg.hamsterLogg = item;
                        //logg.aktivitet = Aktivities.aktivities.motion;
                        //dbContext.logg.Add(logg);
                        RemoveCage(item);
                    }
                    tid++;
                }
                else
                {
                    tid++;
                }
                foreach (var item in dbContext.motionsBatch)
                {
                    message += $"{item.activeHamster.name} motionerar för fullt\n";
                }
                await rapport.ConsoleLog(message);
                dbContext.motionsyta.First().motionTid = tid;
                dbContext.SaveChanges();

            }
        }

        public void FindCage(Hamster hamster)
        {
            int[] arr = new int[11];

            using (var dbContext = new DbContextHamster())
            {
                foreach (var item in dbContext.cageBuddies)
                {
                    arr[item.filledCage.cageNumber]++;                    
                }
                foreach (var item in dbContext.cages)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (item.cageNumber == i && arr[i] < 3)
                        {
                            SqlConnection conn = new SqlConnection(
                              @"Server=LAPTOP-6GH4TEP5\SQLEXPRESS;Database=advBjornEklund;Trusted_Connection=True;MultipleActiveResultSets=true");
                            SqlDataReader rdr = null;
                            string query = $"INSERT INTO cageBuddies VALUES({hamster.ID}, {item.ID})";

                                using(conn)
                                {
                                    conn.Open();
                                    SqlCommand cmd = new SqlCommand(query, conn);
                                    rdr = cmd.ExecuteReader();
                                        while(rdr.Read())
                                        {

                                        }
                                conn.Close();
                                }
                            goto slut;
                        }
                    }
                }
                slut:
                dbContext.SaveChanges();
            }
        }
        public void RemoveCage(Hamster hamster)
        {
            using (var dbContext = new DbContextHamster())
            {
                foreach (var item in dbContext.cageBuddies)
                {
                    if(item.cageHamster.name == hamster.name)
                    {
                        dbContext.Remove(item);
                    }
                }
                dbContext.SaveChanges();
            }
        }
        private List<Hamster> MotionSorted()
        {
            using (var dbContext = new DbContextHamster())
            {
                var tempList =  dbContext.hamsters.OrderBy(x => x.senastMotioneradTid).ToList();
                return tempList;
            }
        }
    }
}
