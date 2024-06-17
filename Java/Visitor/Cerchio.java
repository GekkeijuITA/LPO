package Java.Visitor;

public class Cerchio implements Forma{
    @Override
    public void accept(Visitor visitor) {
        visitor.visit(this);
    }

    @Override
    public double getArea() {
        return 2.3;
    }
    
}
