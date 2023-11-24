namespace obiektowe1
{

    public class samochod
    {
        public string marka;
        protected string model;
        public int moc;
        public double pojemnosc;

        public void wyswietl()
        {
            Console.WriteLine("Marka: " + this.marka + " Model: " + this.model
                              + " Moc: " + this.moc + " Pojemnosc: " + this.pojemnosc
                             );
        }

        public samochod(string marka, string model, int moc, double p)
        {
            this.marka = marka;
            this.model = model;
            this.moc = moc;
            this.pojemnosc = p;
        }

        public void zmien(string marka, string model, int moc, double p)
        {
            this.marka = marka;
            this.model = model;
            this.moc = moc;
            this.pojemnosc = p;
        }

       public samochod()
        {
            this.marka = "brak";
            this.model = "brak";
            this.moc = 0;
            this.pojemnosc = 0.0;
        }


        static void Main(string[] args)
        {
            samochod s1 = new samochod();//utworzenie obiektu
            samochod s2 = new samochod();
            samochod s3 = new samochod("Audi", "A8", 350, 4.2);
            autobus a1 = new autobus("Mercedes", "5000", 500, 8.0, 60);

            s1.zmien("Ford", "Mustang", 200, 5.0);
            s1.wyswietl();
            s2.wyswietl();
            s3.wyswietl();
            s3.zmien("Audi", "A6", 250, 3.0);
            s3.wyswietl();
            a1.wyswietl();
            //Console.WriteLine(s1.marka);





        }
    }


    public class autobus : samochod {
        int ilosc_miejsc;

      public  autobus(string marka, string model, int moc,double pojemnosc,int ilosc_miejsc): base(marka,model,moc,pojemnosc)
        {
            this.ilosc_miejsc = ilosc_miejsc;

        }
        public void wyswietl()
        {
            Console.WriteLine("Marka: " + this.marka + " Model: " + this.model
                              + " Moc: " + this.moc + " Pojemnosc: " + this.pojemnosc
                              + " Ilość miejsc: " + this.ilosc_miejsc
                             ) ;
        }


    }
}