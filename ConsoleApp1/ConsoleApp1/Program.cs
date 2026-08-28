// https://github.com/0wan1001/kiosk
using System;
using System.Collections.Generic; 

class Program
{
    const string SHOP_NAME = "디벨마켓";
    
    static void Main(string[] args)
    {
        List<Menu> menuList = new List<Menu>();
        menuList.Add(new Cola());
        menuList.Add(new Tea());
        menuList.Add(new Sandwitch());
        menuList.Add(new Burger());
        menuList.Add(new Toothbrush());
        List<ShoppingCart> cart = new List<ShoppingCart>();
        
        while (true)  
        {  
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine($"{SHOP_NAME} 주문 키오스크 ");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("[메뉴판]");
            for (int i = 0; i < menuList.Count; i++)
            {
                Menu item = menuList[i];
                Console.WriteLine($"{i+1}. {item.name} ({item.category}) {item.price}원");
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("[장바구니]");
            Console.WriteLine($"");
            /* menunumber 1 -> picked 메뉴판번호 선택 -> 장바구니 담긴 물품 출력...*/
            Console.WriteLine("------------------------");
            Console.WriteLine("1.담기  2.전체 비우기  3.결제  4.영업 종료");
            /* menunumber 선택하면 그에 맞는 기능 실행. */
            int menuNumber = ConsoleInput.ReadIntInRange("메뉴 번호 : ", 1, 4);
            
            int picked = ConsoleInput.ReadIntInRange("번호 : ", 1, 5);

            ConsoleInput.Pause();  
            
            int paid = ConsoleInput.ReadIntAtLeast("받은 금액 : ", 0);
            
            ConsoleInput.Pause();
        }   
    }
    
}