using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         As01_CheckNumberSign();
         As02_GetDayName();
         As03_ValidatePassword();
         As04_GetGrade();
         As05_IsLeapYear();
         As06_Calculate();
         As07_GetSeason();
         As08_PurchasingSystemExample();
         As09_RockPaperScissorsExample();
         As10_CalculateWeaponDamage();
         As11_DeterminePlayerRank();
    }

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        // TODO: Implement logic to determine sign
        // Example: Debug.Log("Positive");
        if (as01Number > 0)
        {
            Debug.Log("Positive");
        }
        else if (as01Number < 0)
        {
            Debug.Log("Negative");
        }
        else
        {
            Debug.Log("Zero");
        }

        //throw new System.NotImplementedException();
    }

    public int as02Day;
    public void As02_GetDayName()
    {
        // TODO: Implement logic to return day name
        // Example: Debug.Log("Monday");
        if (as02Day == 1)
        {
            Debug.Log("Monday");
        }
        else if (as02Day == 2)
        {
            Debug.Log("Tuesday");
        }
        else if (as02Day == 3)
        {
            Debug.Log("Wednesday");
        }
        else if (as02Day == 4)
        {
            Debug.Log("Thursday");
        }
        else if (as02Day == 5)
        {
            Debug.Log("Friday");
        }
        else if (as02Day == 6)
        {
            Debug.Log("Saturday");
        }
        else if (as02Day == 7)
        {
            Debug.Log("Sunday");
        }
        else
        {
            Debug.Log("Invalid day number");
        }


        //throw new System.NotImplementedException();
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        // TODO: Implement password validation logic
        // Example: Debug.Log("True");
        if (as03InputPassword == as03CorrectPassword)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
        //throw new System.NotImplementedException();
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        // TODO: Implement logic to return grade
        // Example: Debug.Log("A");
        if (as04Score >= 80)
        {
            Debug.Log("A");
        }
        else if (as04Score >= 70)
        {
            Debug.Log("B");
        }
        else if (as04Score >= 60)
        {
            Debug.Log("C");
        }
        else if (as04Score >= 50)
        {
            Debug.Log("D");
        }
        else
        {
            Debug.Log("F");
        }
        //throw new System.NotImplementedException();
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        // TODO: Implement leap year check logic
        // Example: Debug.Log("True");
        if (as05Year % 400 == 0)
        {
            Debug.Log("True");
        }
        else if (as05Year % 100 == 0)
        {
            Debug.Log("False");
        }
        else if (as05Year % 4 == 0)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
        //throw new System.NotImplementedException();
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public void As06_Calculate()
    {
        // TODO: Implement calculator logic
        // Example: Debug.Log("Result: 42");
        if (as06Op == '+')
        {
            Debug.Log("Result: " + (as06Num1 + as06Num2));
        }
        else if (as06Op == '-')
        {
            Debug.Log("Result: " + (as06Num1 - as06Num2));
        }
        else if (as06Op == '*')
        {
            Debug.Log("Result: " + (as06Num1 * as06Num2));
        }
        else if (as06Op == '/')
        {
            if (as06Num2 != 0)
            {
                Debug.Log("Result: " + (as06Num1 / as06Num2));
            }
            else
            {
                Debug.Log("Error: Cannot divide by zero");
            }
        }
        else
        {
            Debug.Log("Error: Invalid operator. Please use +, -, *, or /.");
        }
        //throw new System.NotImplementedException();
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        // TODO: Implement logic to return season
        // Example: Debug.Log("Summer");
        if (as07Month >= 1 && as07Month <= 12)
        {
            if (as07Month == 12 || as07Month == 1 || as07Month == 2)
            {
                Debug.Log("Winter");
            }
            else if (as07Month >= 3 && as07Month <= 5)
            {
                Debug.Log("Spring");
            }
            else if (as07Month >= 6 && as07Month <= 8)
            {
                Debug.Log("Summer");
            }
            else if (as07Month >= 9 && as07Month <= 11)
            {
                Debug.Log("Fall");
            }
        }
        else
        {
            Debug.Log("Invalid month number. Please enter a number between 1 and 12.");
        }
            //throw new System.NotImplementedException();
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        if (as08Quantity <= 0) //ตรวจสอบว่ามีสินค้าหรือไม่ ถ้าไม่มีให้แสดงข้อความว่าสินค้าหมด
        {
            Debug.Log("สินค้าหมด");
            return;
        }
        else if (as08Quantity > 0)
        {
            if (as08Payment == as08Price)
            {
                Debug.Log("ซื้อสินค้าเรียบร้อย");
            }
            else if (as08Payment > as08Price)
            {
                Debug.Log("ซื้อสินค้าเรียบร้อย");
                Debug.Log("เงินทอน: Result บาท" + (as08Payment - as08Price));
            }
            else if (as08Payment < as08Price)
            {
                Debug.Log("เงินไม่พอ");
            }
        }
        //throw new System.NotImplementedException();
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        if (as09UserChoice < 0 || as09UserChoice > 2)//ตรวจสอบว่าผู้เล่นเลือกตัวเลขที่ถูกต้องหรือไม่ ต้องไม่น้อยกว่า 0 หรือ ไม่มากกว่า 2
        { 
            Debug.Log("กรุณาเลือกเป็นตัวเลขทีถูกต้อง");
        }
        else if (as09UserChoice == as09ComputerChoice)
        {
            Debug.Log("เสมอ");
        }
        else if ((as09UserChoice == 0 && as09ComputerChoice == 2) ||
                 (as09UserChoice == 1 && as09ComputerChoice == 0) ||
                 (as09UserChoice == 2 && as09ComputerChoice == 1))
        {
            Debug.Log("คุณชนะ!");
        }
        else
        {
            Debug.Log("คุณแพ้!");
        }
        //throw new System.NotImplementedException();
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
       double multiplier = 1.0; //ประกาศตัวแปลสำหรับ bonus damage multiplier

        switch (as10WeaponType.ToLower()) 
        {
            case "sword":
                multiplier = 1.3;
                break;
            case "axe":
                multiplier = 1.4;
                break;
            case "staff":
                multiplier = 1.5;
                break;
            case "bow":
                multiplier = 1.2;
                break;
            case "dagger":
                multiplier = 1.1;
                break;
            default:
                Debug.Log("Invalid weapon type");
                return;
        }
        int totalDamage = (int)(as10BaseDamage * multiplier); //คำนวณ total damage โดยการนำ basedamage มาคูณกับ bonus damage multiplier
        Debug.Log(totalDamage.ToString());

        //throw new System.NotImplementedException();
    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        if (as11Score < 0 || as11CompletionTime < 0)
        {
            Debug.Log("Invalid score or completion time");
            return;
        }

        string rank; //ประกาศตัวแปลสำหรับ rank
        int baseCoin; //ประกาศตัวแปลสำหรับ base coin

        if (as11Score >= 8000)
        {
            rank = "Gold"; baseCoin = 100; 
        }
        else if (as11Score >= 6000)
        {
            rank = "Silver"; baseCoin = 75;
        }
        else if(as11Score >= 4000)
        {
            rank = "Bronze"; baseCoin = 50;
        }
        else 
        {
            rank = "Participation"; baseCoin = 25;
        }

        int timebonus; //ประกาศตัวแปลสำหรับ time bonus

        if (as11CompletionTime <= 30)
        {
            timebonus = 25;
        }
        else if (as11CompletionTime <= 60)
        {
            timebonus = 10;
        }
        else 
        {
            timebonus = 0;
        }

        int totalCoin = timebonus + baseCoin; //นำสองตัวแปลมาบวกกันเพื่อหาผลรวมของเหรียญทั้งหมด
        Debug.Log($"{rank} Rank, {totalCoin} coins earned!");
        
        //throw new System.NotImplementedException();
    }
}
