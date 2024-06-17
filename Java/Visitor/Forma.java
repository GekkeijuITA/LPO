package Java.Visitor;

public interface Forma {
    void accept(Visitor visitor);
    double getArea();
}
