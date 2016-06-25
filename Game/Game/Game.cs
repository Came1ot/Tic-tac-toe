using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace курс
{
    public struct OneItem
    {
        public string[] strings;
        public OneItem(int n)
        {
            strings = new string[n];
        }
    };

    public class Car
    {
        public int Number;
        public float[] t;
        public int ShopCount;
        public int ShopNumber;
        public bool InQuery;
        public Car() { }
        public Car(int N, float t0, float t1, int SC, int SN, bool IQ)
        {
            t = new float[2];
            Number = N;
            t[0] = t0;
            t[1] = t1;
            ShopCount = SC;
            ShopNumber = SN;
            InQuery = IQ;
        }
        public void Reset()
        {
            t[0] = 0;
            t[1] = -1;
            ShopCount = 0;
            ShopNumber = -1;
            InQuery = false;
        }

    };


    public class Shop
    {
        public float t;
        public List<Car> Query;
        public Shop()
        {
            t = 0;
            Query = new List<Car>();
        }
        public void Reset()
        {
            t = 0;
            Query = new List<Car>();
        }
    };

    public class BreadPlant
    {
        public float t;
        public List<Car> Query;
        public BreadPlant()
        {
            t = 0;
            Query = new List<Car>();
        }
    }

    public class ModellingCars
    {
        List<Car> Cars;
        List<Shop> Shops;
        BreadPlant Plant;
        public float M1;
        public float S1;
        public float M2;
        public float S2;

        public float CurM;
        public float CurS;

        int CurrentShop;

        static float[] ArrayP = { (float)0.4, (float)0.6 };

        Random rnd = new Random();

        public ModellingCars()
        {
            int i, n;
            n = 6;

            Shops = new List<Shop>();

            for (i = 0; i < n; i++)
            {
                Shops.Add(new Shop());
            }

            M1 = 10;
            S1 = 3;
            M2 = 15;
            S2 = 5;

            CurM = M1;
            CurS = S1;

            rnd = new Random();

            Cars = new List<Car>();
        }

        public int ModellingFullGroupEvent(float[] ArrayP)
        {
            float l, e;
            int i, n;

            l = 0;
            n = ArrayP.Length;
            e = (float)rnd.NextDouble();
            for (i = 0; i < n; i++)
            {
                l += ArrayP[i];
                if (e <= l)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool ModellingSingleEvent(float P)
        {

            if ((float)rnd.NextDouble() < P)
            {
                return true;
            }
            return false;
        }

        public float Normal(float M, float S)
        {

            int i, k;

            float y = 0, x, A, B;
            k = rnd.Next(8, 20);
            A = M / k - (float)(Math.Pow(3, 0.5) * S / k);
            B = M / k + (float)(Math.Pow(3, 0.5) * S / k);
            for (i = 0; i < k; i++)
            {

                x = A + (float)((B - A) * rnd.NextDouble());
                y += x;
            }
            return y;
        }

        public float Exponent(float M)
        {

            float y;
            y = -M * (float)Math.Log(rnd.NextDouble());
            return y;
        }

        public void ResetCars()
        {
            int i;
            for (i = 0; i < Cars.Count; i++)
            {
                Cars[i].Reset();
            }
        }

        public void AddCar()
        {
            Cars.Add(new Car(Cars.Count, 0, -1, 0, -1, false));
        }


        public void FormCars(int n)
        {
            int i;
            if (Cars.Count != n)
            {
                Cars = new List<Car>();
                for (i = 0; i < n; i++)
                {
                    AddCar();
                }
            }
            else
            {
                ResetCars();
            }
        }

        public void ResetShops()
        {
            int i;
            for (i = 0; i < Shops.Count; i++)
            {
                Shops[i].Reset();
            }
        }
        void NextShop()
        {
            CurrentShop++;
            if (CurrentShop == Shops.Count)
            {
                CurrentShop = 0;
            }
        }

        void SearchCurrenrEvent(ref int Place, ref int CarNumber)
        {
            int i, j;
            float MinTime = 10000;
            int MinTimeCarNumber = -1;
            int CurrentPlace = -1;
            for (i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].InQuery == false)
                {
                    for (j = 0; j < Cars[i].t.Length; j++)
                    {
                        if (Cars[i].t[j] < MinTime && Cars[i].t[j] != -1)
                        {
                            MinTime = Cars[i].t[j];
                            MinTimeCarNumber = i;
                            CurrentPlace = j;
                            if (MinTime == 0) break;
                        }
                    }
                }
            }
            Place = CurrentPlace;
            CarNumber = MinTimeCarNumber;
        }


        public List<OneItem> MainModelling(int k1, int k2)
        {
            int i;
            int CurrentPlace = -1;
            int CurrentCar = 0;
            float OldTime;
            float OldCarTime;
            float ServiceTime;
            float TimeToNext;
            CurrentShop = 0;
            OneItem Item = new OneItem(8);
            Car CarFromQuery = new Car();
            ResetCars();
            ResetShops();
            Plant = new BreadPlant();

            List<OneItem> ModellingResult = new List<OneItem>();

            for (i = 0; i < k1; i++)
            {
                SearchCurrenrEvent(ref CurrentPlace, ref CurrentCar);
            Plant:
                if (CurrentPlace == 0)
                {
                    if (Plant.t <= Cars[CurrentCar].t[0])
                    {

                        if (Plant.Query.Count == 0)
                        {


                            OldTime = Plant.t;
                            Plant.t = Cars[CurrentCar].t[0];
                            ServiceTime = Normal(CurM, CurS);
                            Plant.t += ServiceTime;
                            OldCarTime = Cars[CurrentCar].t[0];
                            Cars[CurrentCar].t[0] += ServiceTime;
                            Cars[CurrentCar].ShopCount = ModellingFullGroupEvent(ArrayP) + 1;
                            Cars[CurrentCar].ShopNumber = CurrentShop;
                            NextShop();
                            if (Cars[CurrentCar].ShopCount == 2)
                            {
                                NextShop();
                            }
                            TimeToNext = Exponent(30);
                            Cars[CurrentCar].t[1] = Cars[CurrentCar].t[0] + TimeToNext;
                            Cars[CurrentCar].t[0] = -1;

                            Item = new OneItem(8);

                            Item.strings[0] = (Cars[CurrentCar].Number + 1).ToString();
                            Item.strings[1] = "хлебозавод";
                            Item.strings[2] = String.Format("{0:0.00}", OldCarTime);
                            Item.strings[3] = String.Format("{0:0.00}", OldTime);
                            Item.strings[4] = String.Format("{0:0.00}", ServiceTime);
                            Item.strings[5] = String.Format("{0:0.00}", Plant.t);
                            Item.strings[6] = String.Format("{0:0.00}", TimeToNext);
                            Item.strings[7] = "Отправлен в магазин №" + (Cars[CurrentCar].ShopNumber + 1).ToString();
                            if (Cars[CurrentCar].ShopCount == 2)
                            {
                                if (Cars[CurrentCar].ShopNumber == Shops.Count - 1)
                                {
                                    Item.strings[7] += " и магазин №1";
                                }
                                else
                                {
                                    Item.strings[7] += " и магазин №" + (Cars[CurrentCar].ShopNumber + 2).ToString();
                                }
                            }
                            ModellingResult.Add(Item);
                        }
                        else
                        {

                            CarFromQuery = Plant.Query[0];
                            Plant.Query.RemoveAt(0);
                            Cars[CarFromQuery.Number].InQuery = false;
                            OldTime = Plant.t;
                            ServiceTime = Normal(CurM, CurS);
                            Plant.t += ServiceTime;
                            OldCarTime = Cars[CarFromQuery.Number].t[0];
                            Cars[CarFromQuery.Number].t[0] = Plant.t + ServiceTime;
                            Cars[CarFromQuery.Number].ShopCount = ModellingFullGroupEvent(ArrayP) + 1;
                            Cars[CarFromQuery.Number].ShopNumber = CurrentShop;
                            NextShop();
                            if (Cars[CarFromQuery.Number].ShopCount == 2)
                            {
                                NextShop();
                            }
                            TimeToNext = Exponent(30);
                            Cars[CarFromQuery.Number].t[1] = Cars[CarFromQuery.Number].t[0] + TimeToNext;
                            Cars[CarFromQuery.Number].t[0] = -1;
                            Item = new OneItem(8);
                            Item.strings[0] = (Cars[CarFromQuery.Number].Number + 1).ToString();
                            Item.strings[1] = "хлебозавод";
                            Item.strings[2] = String.Format("{0:0.00}", OldCarTime);
                            Item.strings[3] = String.Format("{0:0.00}", OldTime);
                            Item.strings[4] = String.Format("{0:0.00}", ServiceTime);
                            Item.strings[5] = String.Format("{0:0.00}", Plant.t);
                            Item.strings[6] = String.Format("{0:0.00}", TimeToNext);
                            Item.strings[7] = "Извлечен из очереди. Отправлен в магазин            №" + (Cars[CarFromQuery.Number].ShopNumber + 1).ToString();
                            if (Cars[CarFromQuery.Number].ShopCount == 2)
                            {
                                if (Cars[CarFromQuery.Number].ShopNumber == Shops.Count - 1)
                                {
                                    Item.strings[7] += " и магазин №1";
                                }
                                else
                                {
                                    Item.strings[7] += " и магазин №" + (Cars[CarFromQuery.Number].ShopNumber + 2).ToString();
                                }

                            }
                            ModellingResult.Add(Item);
                            i++;
                            goto Plant;
                        }
                    }
                    else
                    {
                        Plant.Query.Add(Cars[CurrentCar]);
                        Cars[CurrentCar].InQuery = true;

                        Item = new OneItem(8);

                        Item.strings[0] = (Cars[CurrentCar].Number + 1).ToString();
                        Item.strings[1] = "хлебозавод";
                        Item.strings[2] = String.Format("{0:0.00}", Cars[CurrentCar].t[0]);
                        Item.strings[3] = String.Format("{0:0.00}", Plant.t);
                        Item.strings[4] = String.Format("---");
                        Item.strings[5] = String.Format("---");
                        Item.strings[6] = String.Format("---");
                        Item.strings[7] = "Добавлен в очередь";
                        ModellingResult.Add(Item);
                    }
                }

                else
                {
                Shops:
                    if (Shops[Cars[CurrentCar].ShopNumber].t <= Cars[CurrentCar].t[1])
                    {
                        if (Shops[Cars[CurrentCar].ShopNumber].Query.Count == 0)
                        {

                            OldTime = Shops[Cars[CurrentCar].ShopNumber].t;
                            Shops[Cars[CurrentCar].ShopNumber].t = Cars[CurrentCar].t[1];
                            ServiceTime = Exponent(20);
                            if (ModellingSingleEvent((float)0.1))
                            {
                                ServiceTime *= (float)1.3;
                            }
                            Shops[Cars[CurrentCar].ShopNumber].t += ServiceTime;
                            OldCarTime = Cars[CurrentCar].t[1];
                            Cars[CurrentCar].t[1] += ServiceTime;
                            Cars[CurrentCar].ShopCount--;

                            if (Cars[CurrentCar].ShopCount == 0)
                            {
                                TimeToNext = Exponent(20);
                                Cars[CurrentCar].t[0] = Cars[CurrentCar].t[1] + TimeToNext;
                                Cars[CurrentCar].t[1] = -1;
                            }
                            else
                            {
                                TimeToNext = Exponent(10);
                                Cars[CurrentCar].t[1] += TimeToNext;
                            }

                            Item = new OneItem(8);

                            Item.strings[0] = (Cars[CurrentCar].Number + 1).ToString();
                            Item.strings[1] = "магазин №" + (Cars[CurrentCar].ShopNumber + 1).ToString();
                            Item.strings[2] = String.Format("{0:0.00}", OldCarTime);
                            Item.strings[3] = String.Format("{0:0.00}", OldTime);
                            Item.strings[4] = String.Format("{0:0.00}", ServiceTime);
                            Item.strings[5] = String.Format("{0:0.00}", Shops[Cars[CurrentCar].ShopNumber].t);

                            Item.strings[6] = String.Format("{0:0.00}", TimeToNext);
                            if (Cars[CurrentCar].ShopCount == 1)
                            {
                                if (Cars[CurrentCar].ShopNumber == Shops.Count - 1)
                                {
                                    Item.strings[7] = "Отправлен в магазин №1";
                                }
                                else
                                {
                                    Item.strings[7] = "Отправлен в магазин №" + (Cars[CurrentCar].ShopNumber + 2).ToString();
                                }
                            }
                            else
                            {
                                Item.strings[7] = "Отправлен на хлебозавод";
                            }
                            ModellingResult.Add(Item);

                            Cars[CurrentCar].ShopNumber++;
                            if (Cars[CurrentCar].ShopNumber == Shops.Count)
                            {
                                Cars[CurrentCar].ShopNumber = 0;
                            }
                        }
                        else
                        {


                            CarFromQuery = Shops[Cars[CurrentCar].ShopNumber].Query[0];
                            Shops[Cars[CurrentCar].ShopNumber].Query.RemoveAt(0);
                            Cars[CarFromQuery.Number].InQuery = false;
                            OldTime = Shops[Cars[CurrentCar].ShopNumber].t;
                            ServiceTime = Exponent(20);
                            if (ModellingSingleEvent((float)0.1))
                            {
                                ServiceTime *= (float)1.3;
                            }
                            Shops[Cars[CurrentCar].ShopNumber].t += ServiceTime;
                            OldCarTime = Cars[CarFromQuery.Number].t[1];
                            Cars[CarFromQuery.Number].t[1] += ServiceTime;
                            Cars[CarFromQuery.Number].ShopCount--;

                            if (Cars[CarFromQuery.Number].ShopCount == 0)
                            {
                                TimeToNext = Exponent(20);
                                Cars[CarFromQuery.Number].t[0] = Cars[CarFromQuery.Number].t[1] + TimeToNext;
                                Cars[CarFromQuery.Number].t[1] = -1;

                            }
                            else
                            {
                                TimeToNext = Exponent(10);
                                Cars[CarFromQuery.Number].t[1] += TimeToNext;
                            }

                            Item = new OneItem(8);

                            Item.strings[0] = (Cars[CarFromQuery.Number].Number + 1).ToString();
                            Item.strings[1] = "магазин №" + (Cars[CarFromQuery.Number].ShopNumber + 1).ToString();
                            Item.strings[2] = String.Format("{0:0.00}", OldCarTime);
                            Item.strings[3] = String.Format("{0:0.00}", OldTime);
                            Item.strings[4] = String.Format("{0:0.00}", ServiceTime);
                            Item.strings[5] = String.Format("{0:0.00}", Shops[Cars[CarFromQuery.Number].ShopNumber].t);
                            Item.strings[6] = String.Format("{0:0.00}", TimeToNext);
                            Item.strings[7] = "Извлечение из очереди. ";

                            if (Cars[CarFromQuery.Number].ShopCount == 1)
                            {
                                if (Cars[CarFromQuery.Number].ShopNumber == Shops.Count - 1)
                                {
                                    Item.strings[7] = "Отправлен в магазин №1";
                                }
                                else
                                {
                                    Item.strings[7] += ("Отправлен в магазин №" + (Cars[CarFromQuery.Number].ShopNumber + 2).ToString());
                                }
                            }
                            else
                            {
                                Item.strings[7] += ("Отправлен на хлебозавод");
                            }
                            ModellingResult.Add(Item);
                            Cars[CarFromQuery.Number].ShopNumber++;
                            if (Cars[CarFromQuery.Number].ShopNumber == Shops.Count)
                            {
                                Cars[CarFromQuery.Number].ShopNumber = 0;
                            }
                            i++;
                            goto Shops;
                        }
                    }
                    else
                    {
                        //добавляем в очередь магазина
                        Shops[Cars[CurrentCar].ShopNumber].Query.Add(Cars[CurrentCar]);
                        Cars[CurrentCar].InQuery = true;

                        Item = new OneItem(8);

                        Item.strings[0] = (Cars[CurrentCar].Number + 1).ToString();
                        Item.strings[1] = "магазин №" + (Cars[CurrentCar].ShopNumber + 1).ToString();
                        Item.strings[2] = String.Format("{0:0.00}", Cars[CurrentCar].t[1]);
                        Item.strings[3] = String.Format("{0:0.00}", Shops[Cars[CurrentCar].ShopNumber].t);
                        Item.strings[4] = String.Format("---");
                        Item.strings[5] = String.Format("---");
                        Item.strings[6] = String.Format("---");
                        Item.strings[7] = "Добавлен в очередь";
                        ModellingResult.Add(Item);
                    }
                }
            }

            return ModellingResult;
        }
    }
}
