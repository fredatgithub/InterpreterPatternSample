using System;
using System.Collections.Generic;

namespace InterpreterDemo
{
  class Program
  {
    static void Main()
    {
      var sandwhich = new Sandwhich(
          new WheatBread(),
          new CondimentList(
              new List<ICondiment> { new MayoCondiment(), new MustardCondiment() }),
          new IngredientList(
              new List<IIngredient> { new LettuceIngredient(), new ChickenIngredient() }),
          new CondimentList(new List<ICondiment> { new KetchupCondiment() }),
          new WheatBread());

      sandwhich.Interpret(new Context());


      Console.ReadKey();
    }
  }
}
