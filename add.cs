using System;


namespace add{
public class addition{

    public int start;
    public int end;
    public int fnumber;
    public int lnumber;

    public addition(){
        //constructor
        start=0;
        end=0;

    }
    public int ranFnumber(int start, int end){
        Random rnd = new Random();
        fnumber=rnd.Next(start, end);
        return fnumber;
        

    }

    public int ranLnumber(int start, int end){
        Random rnd = new Random();
        lnumber=rnd.Next(start, end);
        return lnumber;
    }


}

}