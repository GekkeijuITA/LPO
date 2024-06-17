package Java.Visitor;

public class Main {
    public static void main(String[] args) {
        Forma[] forme = {new Cerchio(), new Triangolo(), new Rettangolo()};
        
        CalcolaAreaVisitor cav = new CalcolaAreaVisitor();

        for(Forma forma:forme)
        {
            forma.accept(cav);
        }

        System.out.println("Area tot: " + cav.getAreaTot());
    }
}
