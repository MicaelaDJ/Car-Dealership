using System;

namespace Dealership {

  class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private string Info;

    public Car(string makeModel, int price, int miles, string info)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Info = info;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public string GetInfo()
    {
      return Info;
    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return (Price < maxPrice && Miles < maxMiles);
    }

  }

}
