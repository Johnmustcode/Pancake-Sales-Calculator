// See https://aka.ms/new-console-template for more information
using System;
namespace CakeStore
{
    public enum Toppings { pancake, egg, sausage, doughstick , crispcake, potato , kelp ,
        carrot, beansprout, sauce, scallion, cilantro , pepper};
    public enum ToppingCH { 饼,鸡蛋,火腿肠,油条,脆饼,土豆丝,海带丝,胡萝卜丝,豆芽,酱,葱,香菜,辣椒 }

    class Cost
    {
            public double[] TotalTopNum = new double[13];
            public static double[] ToppNum = new double[] { 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1 };//配料默认的数量
            protected static double[] TopCost = new double[] { 1, 0.2, 0.5, 0.3, 0.4, 0.2, 0.2, 0.2, 0.1, 0.3, 0.1, 0.1, 0.1 };//配料的成本
            public void AskNum()
            {
                for(int i = 0;i<13;i++)
                {
                if (i < 9)
                    Console.WriteLine("请问需要几个{0}", Enum.GetName(typeof(ToppingCH), i));
                else
                    Console.WriteLine("请问需要几份{0}", Enum.GetName(typeof(ToppingCH), i));
                    double ans = Convert.ToDouble(Console.ReadLine());
                    ToppNum[i] = ans;
                    TotalTopNum[i] += ans;
                }
            }
            public double CalTotalCost()//计算所有的成本
            {
                double ans = 0;
                for (int i = 0; i < 13; i++)
                {
                    double temp;
                    temp = (TotalTopNum[i] * TopCost[i]);
                    ans += temp;
                }
                return ans;
            }

    }


    class TotalPrice:Cost
    {
        public static double[] norprice = new double[] { 4, 2, 2, 2, 2, 1.5, 1.5, 1.5, 1.5, 1, 1, 1, 1 };
        public double CalTotalPrice()
        {
            double ans = 0;
            for(int i = 0;i<13;i++)
            {
                double temp;
                temp = (ToppNum[i] * norprice[i]);
                ans += temp;
            }
            return ans;
        }
        
    }

    class VipTotalPrice: Cost
    {
            public static double[] vipprice = new double[] { 3, 1, 1, 1.5, 1, 1, 1, 1, 1 , 0.8 , 0.5 ,0.5 ,0.5};
            public double VipCalTotalPrice()
            {
                
                double ans = 0;
                for (int i = 0; i < 13; i++)
                {
                    double temp;
                    temp = (ToppNum[i] * vipprice[i]);
                    ans += temp;
                }
            return ans;
            }

    }
   


    class ExecuteApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("需要煎饼嘛？");
            string? flag = Console.ReadLine();
            if (flag == "Yes")
            {
                Console.WriteLine("请问有VIP卡吗？");
                flag = Console.ReadLine();
                if( flag == "Yes")// 两种情况
                {
                    Console.WriteLine("请问需要几个煎饼？");
                    int num = Convert.ToInt32(Console.ReadLine());
                    double ans = 0;
                    VipTotalPrice t = new VipTotalPrice();
                    int j = 1;
                    while (j <= num)
                    {
                        Console.WriteLine("这是第{0}个煎饼", j);
                        t.AskNum();
                        ans += t.VipCalTotalPrice();
                        j++;
                    }
                    for(int i=0 ; i<13 ; i++)
                    {
                        Console.WriteLine("{0}的总数量为{1}", Enum.GetName(typeof(ToppingCH), i), t.TotalTopNum[i]);
                    }
                    Console.WriteLine("总的价格是{0:f2}", ans);
                    Console.WriteLine("总的成本为{0:f2}", t.CalTotalCost());
                    Console.WriteLine("总的利润为{0:f2}", ans - t.CalTotalCost());
                    Console.ReadLine();
                }
                else//不是VIP的情况
                {
                    Console.WriteLine("请问需要几个煎饼？");
                    int num = Convert.ToInt32(Console.ReadLine());
                    double ans = 0;
                    TotalPrice t = new TotalPrice();
                    int j = 1;
                    while (j <= num)
                    {
                        Console.WriteLine("这是第{0}个煎饼", j);
                        t.AskNum();
                        ans += t.CalTotalPrice();
                        j++;
                    }
                    
                    for (int i = 0; i < 13; i++)
                    {
                        Console.WriteLine("{0}的总数量为{1}", Enum.GetName(typeof(ToppingCH), i), t.TotalTopNum[i]);
                    }
                    Console.WriteLine("总的价格是{0:f2}", ans);
                    Console.WriteLine("总的成本为{0:f2}", t.CalTotalCost());
                    Console.WriteLine("总的利润为{0:f2}", ans - t.CalTotalCost());
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine("快买不要逼我求你");
                Console.ReadLine();
            }
        }
    }

}




