package Java.Visitor;

public interface Visitor<T> {
    void visit(Cerchio c);
    void visit(Rettangolo r);
    void visit(Triangolo t);
}