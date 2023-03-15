Console.Clear();
int xa = 40, ya = 1;
int xb = 1, yb = 30;
int xc = 80, yc = 30;
Console.SetCursortPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursortPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursortPosition(xc, yc);
Console.WriteLine("+");
int x = xa, y = xb;
int count = 0;
while (count < 10000)
{
  Int what = new Random().Next(0, 3);
  if(what==0)
  {
    x=(x+xa)/2;
    y=(y+ya)/2;
  }
  if(what==1)
  {
    x=(x+xb)/2;
    y=(y+yb)/2;
  }
  if(what==2)
  {
    x=(x+xb)/2;
    y=(y+yb)/2;
  }
  Console.SetCursortPosition(x, y);
  Console.WriteLine("+");
  count++;
}
