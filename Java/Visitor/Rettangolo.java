package Java.Visitor;

public class Rettangolo implements Forma{

    @Override
    public void accept(Visitor visitor) {
        visitor.visit(this);
    }

	@Override
	public double getArea() {
		return 1.4;
	}
    
}
