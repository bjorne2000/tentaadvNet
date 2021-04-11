using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BackendHamster.Hamster;

namespace BackendHamster.Operations
{
    public class CreateObjects
    {
        public static void readHamsterCSV()
        {
            var initialList = new List<Hamster>();
                
                    string[] lines = File.ReadAllLines(@"HamsterLista.txt");

                    for (int i = 0; i < lines.Length; i++)
                    {
                        Hamster hamster = new Hamster();
                       
                    string[] fields = lines[i].Split(";");
                       
                    hamster.name = fields[0];                      
                    hamster.age = int.Parse(fields[1]);
                    hamster.gender = fields[2] is "0" ? Gender.Male : Gender.Feamale;
                    hamster.ownerName = fields[3];                        
                    initialList.Add(hamster);                    
                    }

            using (var dbContext = new DbContextHamster())
            {
                foreach (var item in initialList)
                {
                    dbContext.hamsters.Add(item);
                }
                dbContext.SaveChanges();
            }
        }
        public static void CreateCages()
        {
            using(var dbContext = new DbContextHamster())
            {

                int count = 1;
                for (int i = 0; i < 10; i++)
                                
                {                    
                    Cage tempCage = new Cage(count);                    
                    dbContext.cages.Add(tempCage);
                    count++;

                }
                dbContext.SaveChanges();
            }
        }

        public static void CreateMotionsArea()
        {
            using(var dbContext = new DbContextHamster())
            {
                var motionsYta = new Motionsyta();
                dbContext.motionsyta.Add(motionsYta);
                dbContext.SaveChanges();
            }
        }
        public CreateObjects()
        {

        }
    }
}
