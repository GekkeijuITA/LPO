package Java.Visitor;

public class Triangolo implements Forma{

    @Override
    public void accept(Visitor visitor) {
        visitor.visit(this);
    }

    @Override
    public double getArea() {
        return 1;
    }
    
}
