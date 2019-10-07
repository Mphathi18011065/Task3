using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task2_18011065_MphathiMaapola
{ 


      
class FactoryBuilding : Building
    {
        Random r = new Random();
        List<Unit> units = new List<Unit>();

        List<FactoryBuilding> buildings;

        TextBox txtInfo;

        string symbol = "◙";
        private int xPos;


        public int Xpos
        {
            get { return xPos; }
            set { xPos = value; }
        }
        private int yPos;

        public int Ypos
        {
            get { return yPos; }
            set { yPos = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int health;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        private int maxHealth;

        public int MaxHealth 
        {
            get { return maxHealth; }
            
        }

        public int Faction
        {
            get { return faction; }
            set { faction = value; }
        }

        public string Symbol
        {
            get { return symbol; }
            set { symbol =" [f]"; }
        }


        public FactoryBuilding(int v1, int v2, int v3,int v6, string v4, string v5) // Factory constructor 
        {
            Xpos = v1;
            Ypos = v2;
            Faction = v3;
            Symbol = v4;
            Name = v5;
            Health = v6; // Factory health 
                
          //  GenerateUnits(20);
          //  Display();
        }



 



        public override void Destrcution()
        {
            throw new NotImplementedException();
        }
        public override void Save(Building b ) // Serialize save 
        {

        }

        public override string ToString()
        {
            string temp = "";
            temp += "Co-ordintes : " + "(" + Xpos + "," + Ypos + ")";
            temp += "SYmbol :" + Symbol;
            temp += "Resource Name " + name;
            return temp;
        }
        //Produces units every 
        public void Spawnunit(int numRounds)
        {
            for (int i = 0; i < numRounds; i++)
            {
                if (r.Next(0, 2) == 0) //Generate 
                {
                    MeleeUnit m = new MeleeUnit(r.Next(0, 20),
                                                r.Next(0, 20),
                                                100,
                                                1,
                                                20,
                                                (i % 2 == 0 ? 1 : 0),
                                                "%",
                                                "");
                    units.Add(m);
                }
                else // Generate Ranged Unit
                {
                    RangedUnit ru = new RangedUnit(r.Next(0, 20),
                                                r.Next(0, 20),
                                                100,
                                                1,
                                                20,
                                                5,
                                                (i % 2 == 0 ? 1 : 0),
                                                "~",
                                                "");
                    units.Add(ru);
                }
            }
        }// spwan units in 


        public FactoryBuilding(GroupBox groupBox)
        {
            buildings = new List<FactoryBuilding>();
            for (int j = 0; j < 20 / 2; j++)
            {
                if (r.Next(0, 2) == 0)// generate factory 
                {
                    FactoryBuilding f = new FactoryBuilding(r.Next(0, 20), r.Next(0, 20), (j % 2 == 0 ? 1 : 0), 100, "[F.]", "Factory Building");
                    buildings.Add(f);
                }
            }
            foreach (FactoryBuilding f in buildings)
            {
                Button fb = new Button();
                FactoryBuilding factory = (FactoryBuilding)f;
                fb.Size = new Size(20, 20);
                fb.Location = new Point(r.Next(0, 20)*20, r.Next(0, 20)*20);
                fb.Text = factory.Symbol;

                if (factory.Faction == 0)
                {
                    fb.ForeColor = Color.AliceBlue;
                    fb.BackColor = Color.AntiqueWhite;
                }
                else
                {
                    fb.ForeColor = Color.Green;
                    fb.BackColor = Color.Honeydew;
                }
                fb.Click += Factory_CLick;
                groupBox.Controls.Add(fb);
            }
        }

        public void Unit_Click(object sender, EventArgs e)
        {
            int x, y;
            Button b = (Button)sender;
            x = b.Location.X / 20;
            y = b.Location.Y / 20;
            foreach (Unit u in units)
            {
                if (u is RangedUnit)
                {
                    RangedUnit ru = (RangedUnit)u;
                    if (ru.XPos == x && ru.YPos == y)
                    {
                        txtInfo.Text = "";
                        txtInfo.Text = ru.ToString();
                    }
                }
                else if (u is MeleeUnit)
                {
                    MeleeUnit mu = (MeleeUnit)u;
                    if (mu.XPos == x && mu.YPos == y)
                    {
                        txtInfo.Text = "";
                        txtInfo.Text = mu.ToString();
                    }
                }
            }
        }
        public void Factory_CLick(object sender, EventArgs e)
        {
            int x, y;
            Button b = (Button)sender;
            x = b.Location.X / 20;
            y = b.Location.Y / 20;
            foreach (FactoryBuilding building in buildings)
            {
                if (building is FactoryBuilding)
                {
                    FactoryBuilding f = (FactoryBuilding)building;
                    if (f.Xpos == x && f.Ypos == y)
                    {
                        txtInfo.Text = "";
                        txtInfo.Text = f.ToString();
                    }
                }
            }

        }
        //    public void GenerateUnits(int numRounds)
        //    {
        //        for (int i = 0; i < numRounds; i++)
        //        {
        //            if (r.Next(0, 2) == 0) //Generate Melee Unit
        //            {
        //                MeleeUnit m = new MeleeUnit(r.Next(0, 20),
        //                                            r.Next(0, 20),
        //                                            100,
        //                                            1,
        //                                            20,
        //                                            (i % 2 == 0 ? 1 : 0),
        //                                            "%",
        //                                            "");
        //                units.Add(m);
        //            }
        //            else // Generate Ranged Unit
        //            {
        //                RangedUnit ru = new RangedUnit(r.Next(0, 20),
        //                                            r.Next(0, 20),
        //                                            100,
        //                                            1,
        //                                            20,
        //                                            5,
        //                                            (i % 2 == 0 ? 1 : 0),
        //                                            "~",
        //                                            "");
        //                units.Add(ru);
        //            }
        //        }
        //    }
    }
  
}
