using System;
using add;
using sub;
using mul;
using div;

namespace showit{
public class show{
   static int showleftnumber;
    static int showrightnumber;
    

public void RandomAddNumbers(){

    addition showlnum = new addition();
    showleftnumber=showlnum.ranFnumber(1,101);

    addition showrnum = new addition();
    showrightnumber=showrnum.ranLnumber(1,101);

}

public void showaddquestion(){

    Console.WriteLine(showleftnumber+" + "+showrightnumber+" = ");

}




public void RandomSubNumbers(){

    subtraction showlnum = new subtraction();
    showleftnumber=showlnum.ranFnumber(1,101);

    subtraction showrnum = new subtraction();
    showrightnumber=showrnum.ranLnumber(20,51);
    
}

public void showSubquestion(){
    
    if (showleftnumber > showrightnumber && showrightnumber>9){
        Console.WriteLine(showleftnumber+" - "+showrightnumber+" = ");
    }
    else{
        RandomSubNumbers();
        showSubquestion();
        }
}




public void RandomMulNumbers(){

    subtraction showlnum = new subtraction();
    showleftnumber=showlnum.ranFnumber(1,2001);

    subtraction showrnum = new subtraction();
    showrightnumber=showrnum.ranLnumber(11,201);
    
}

public void showMulquestion(){
    
    if (showleftnumber > showrightnumber && showrightnumber!=1){
        Console.WriteLine(showleftnumber+" X "+showrightnumber+" = ");
    }
    else{
        RandomMulNumbers();
        showMulquestion();
        }
   
}





public void RandomDivNumbers(){

    subtraction showlnum = new subtraction();
    showleftnumber=showlnum.ranFnumber(1,5001);

    subtraction showrnum = new subtraction();
    showrightnumber=showrnum.ranLnumber(1,10);
    
}

public void showDivquestion(){
    
    if (showleftnumber > showrightnumber && showleftnumber%showrightnumber==0 && showrightnumber!=1)
    {
        Console.WriteLine(showleftnumber+" ÷ "+showrightnumber+" = ");
    }
    else{
        RandomDivNumbers();
        showDivquestion();
    }
   
}
}

}