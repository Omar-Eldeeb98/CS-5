using OOP04.Q1;
using OOP04.Q2;
using OOP04.Q3;

namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1

            #region Q1
            // (b) to define a blueprint of a class
            #endregion

            #region Q2
            // (a) private
            #endregion

            #region Q3
            // (b) No
            #endregion

            #region Q4
            // (b) yes, interface can inherit from multible interfaces.
            #endregion

            #region Q5
            // (d) implements
            #endregion

            #region Q6
            // (a) yes
            #endregion

            #region Q7
            // (b)  no, all members are implicitly public.
            #endregion

            #region Q8
            // (b) to provide a clear separation between interface and class members.
            #endregion

            #region Q9
            // (b) no, interface can not have constructors.
            #endregion

            #region Q10
            // (c) by separating interface names with commas.
            #endregion


            #endregion


            #region Part 2


            #region Q1
            //Define an interface named IShape with a property Area and a method DisplayShapeInfo.
            //Create two interfaces, ICircle and IRectangle, that inherit from IShape.
            //Implement these interfaces in classes Circle and Rectangle.
            //Test your implementation by creating instances of both classes and displaying their shape information.



            //Circle circle = new Circle()
            //{
            //    radius = 10
            //};

            //Rectangle rectangle = new Rectangle()
            //{
            //    length = 10,
            //    width = 20
            //};


            //circle.DisplayShapeInfo();
            //Console.WriteLine("\n");
            //rectangle.DisplayShapeInfo();


            #endregion


            #region Q2


            //IAuthenticationService authService = new BasicAuthenticationService();

            //Console.WriteLine(authService.AuthenticateUser("Michel", "123")); // false
            //Console.WriteLine(authService.AuthenticateUser("user", "password")); // true

            //Console.WriteLine("\n");

            //Console.WriteLine(authService.AuthorizeUser("admin" , "admin")); // true
            //Console.WriteLine(authService.AuthorizeUser("Omar", "Manager")); //false

            #endregion



            #region Q3

            //INotificationService notification1 = new EmailNotificationService();
            //notification1.SendNotification("Omar", "hello my friend!");

            //Console.WriteLine("\n");

            //INotificationService notification2 = new SmsNotificationService();
            //notification2.SendNotification("Omar", "sms from backend!");

            //Console.WriteLine("\n");



            //INotificationService notification3 = new PushNotificationService();
            //notification3.SendNotification("Omar", "notification pushed successfully!");

            #endregion



            #endregion




        }
    }
}
