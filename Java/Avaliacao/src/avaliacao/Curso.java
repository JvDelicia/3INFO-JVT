package avaliacao;

public class Curso {
    int cod, vag, masc, fem;
    
    public Curso(int cod, int vag, int masc, int fem) {
        this.cod = cod;
        this.vag = vag;
        this.masc = masc;
        this.fem = fem;
    }
    
    public int getCod() {
        return this.cod;
    }
    public int getVag() {
        return this.vag;
    }
    public int getMasc() {
        return this.masc;
    }
    public int getFem() {
        return this.fem;
    }
    
}
