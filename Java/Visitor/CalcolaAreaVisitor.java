package Java.Visitor;

public class CalcolaAreaVisitor implements Visitor{

    private double areaTot = 0;

    public double getAreaTot() {
        return areaTot;
    }

    @Override
    public void visit(Cerchio c) {
        areaTot+=c.getArea();
    }

    @Override
    public void visit(Rettangolo r) {
        areaTot+=r.getArea();
    }

    @Override
    public void visit(Triangolo t) {
        areaTot+=t.getArea();
    }
    
}
