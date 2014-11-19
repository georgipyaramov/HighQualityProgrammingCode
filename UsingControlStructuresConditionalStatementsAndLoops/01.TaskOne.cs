using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
        
public class Chef
{
    public void Cook()
    {

    }

    public void Cook()
    {
        Bowl bowl = GetBowl(); ;
        Potato potato = GetPotato();
        Carrot carrot = GetCarrot();

        Peel(potato);
        Peel(carrot);

        Cut(potato);
        Cut(carrot);

        bowl.Add(carrot);
        bowl.Add(potato);
    }

    private Bowl GetBowl()
    {   
        return new Bowl;
    }

    private Potato GetPotato()
    {
        return new Potato;
    }

    private Carrot GetCarrot()
    {
        return new Carrot;
    }

    private void Cut(Vegetable potato)
    {
        //...
    }  

    
}


