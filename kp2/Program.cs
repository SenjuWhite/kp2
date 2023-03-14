
////Кухар Владислав 15 варіант
////f(x)=(Math.Pow(Xlast_mn, 4) -  6.5*Math.Pow(Xlast_mn, 2) + 3),f'(x)=(4 * Math.Pow(Xlast_mn, 3) - 13 * Xlast_mn)
////g(X)(Math.Pow(Xlast_mn, 4) - Math.Pow(Xlast_mn, 2) + 0.25), g'(x)=(4 * Math.Pow(Xlast_mn, 3) - 2 * Xlast_mn)
////p(x) = 1 / Math.Pow(Xlast_pi + 1, 2);
////q(x)= Math.Pow(3*Math.Pow(Xlast_pi,2)-12*Xlast_pi+12,0.3)


////Сельніцина Дар'я 23 варіант 
////f(x)= (Math.Pow(Xlast_mn, 2) - Xlast_mn - 0.75), f'(x)=(2*Xlast_mn-1)     ##(Math.Pow(10,X_mn))##
////g(x)= (Math.Pow(Xlast_mn, 2) - 3 * Xlast_mn + 2.25), g'(x)=(2*Xlast_mn-3) ##(Math.Pow(10,X_mn))##
//p(x)= Math.Sqrt(Math.Sin(0.5*Xlast_pi)+1)
//q(x)=Math.Pow(3*Math.Pow(Xlast_pi,2)-12*Xlast_pi+9,0.3)
//(Math.Pow(Xlast_mn,3)-3*Math.Pow(Xlast_mn,2)+12*Xlast_mn-9)/(3*Math.Pow(Xlast_mn,2)-6*Xlast_mn+12)(формула для q(x) Ньютона


////Марущак Назар 16 варіант 
////f(x)=(Math.Pow(Math.Sin(Xlast_mn*Math.PI/180), 2) + (0.83) * Math.Sin(Xlast_mn * Math.PI / 180) + 0.167),
//f'(x)=(Math.Sin(2 * Xlast_mn * Math.PI / 180) + (5 * Math.Cos(Xlast_mn * Math.PI / 180)) / 6)   ##(X_mn*Math.PI/180)##
////g(x)=(Math.Pow(Math.Sin(Xlast_mn*Math.PI/180), 2) + (0.67) * Math.Sin(Xlast_mn * Math.PI / 180) + 0.11),  ##(X_mn*Math.PI/180)##
//g'(x)=(Math.Sin(2 * Xlast_mn * Math.PI / 180) + (2 * Math.Cos(Xlast_mn * Math.PI / 180)) / 3)
//p(x)=Math.Pow(X_pi,0.3)+1, q(x)=Math.Pow(-0.2 * Math.Pow(Xlast_pi, 2) - 0.5 * Xlast_pi - 0.8, 0.3)
//(Math.Pow(Xlast_mn,3)+0.2*Math.Pow(Xlast_mn,2)+0.5*X_mn+0.8)/(3*Math.Pow(Xlast_mn,2)+0.4*Xlast_mn+0.5)(формула для q(x) для Ньютона


////Скряга Нікіта варіант 24
////f(x)=((Math.Pow(Xlast_mn, 2) + 0.75 * Xlast_mn - 0.25)),f'(x)=(2 * Xlast_mn + 0.75)   ##(Math.Pow(10,X_mn))##
////g(X)=(Math.Pow(Xlast_mn, 2) + 2 * Xlast_mn + 1),g'(x)=(2 * Xlast_mn + 2)    ##(Math.Pow(10,X_mn))##
//q(x)=Math.Pow(-0.2 * Math.Pow(Xlast_pi, 2) - 0.5 * Xlast_pi + 2, 0.33)
//p(x)=(Math.Sin(0.5 + Xlast_pi) + 0.5) / 2

void Func()
{
    double X0 = 2;
    double X_mn = X0, X_smn = X0, X_pi = X0;
    double Xlast_mn, Xlast_smn, Xlast_pi;
    double dx_mn = double.MaxValue, dx_smn = double.MaxValue, dx_pi = double.MaxValue;
    while (Math.Abs(dx_mn) > 1e-6)
    {
        Xlast_mn = X_mn;
        X_mn -= (Math.Pow(Math.Sin(Xlast_mn * Math.PI / 180), 2) + (0.67) * Math.Sin(Xlast_mn * Math.PI / 180) + 0.11) / (Math.Sin(2 * Xlast_mn * Math.PI / 180) + (2 * Math.Cos(Xlast_mn * Math.PI / 180)) / 3);
        dx_mn = X_mn - Xlast_mn;
    }
    Console.WriteLine($"Метод Ньютона: X =  {X_mn*Math.PI/180}");
    while (Math.Abs(dx_smn) > 1e-6)
    {
        Xlast_smn = X_smn;
        X_smn -= (Math.Pow(Xlast_smn, 2) - Xlast_smn - 0.75) / (2 * X0 - 1);
        dx_smn = X_smn - Xlast_smn;
    }
    Console.WriteLine($"Спрощений метод Ньютона: X = {Math.Pow(10,X_smn )}");
    while (Math.Abs(dx_pi) > 1e-6)
    {
        Xlast_pi = X_pi;
        X_pi = (Math.Sin(0.5 + Xlast_pi) + 0.5) / 2;
        dx_pi = X_pi - Xlast_pi;
    }
    Console.WriteLine($"Метод ітерацій: X = {X_pi}");
}
Func();
