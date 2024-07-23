

class Level{
    private int cantDigitos;
    private int vidas;
    private int puntaje;
    private int[] numSecreto;
    

    public Level(int cantDigitos, int vidas){
        this.cantDigitos=cantDigitos;
        this.vidas=vidas;
        this.puntaje=0;
        this.numSecreto = new int[cantDigitos];
    }

    public void generarNumero(){
        var aleatorio = new Random();
        for(int i=0;i<cantDigitos;i++){
            this.numSecreto[i]=aleatorio.Next(0,10);
           // Console.Write(this.numSecreto[i]);
        }
       
        
    }
    

    public int calcularPicas(int[] numero){
        int picas=0;
        for(int i =0;i<numero.Length;i++){
            for(int j =0;j<this.numSecreto.Length;j++){
                //evalua que el número sea igual pero que no se encuentre en la misma posición
                if(i!=j && numero[i]==this.numSecreto[j]){
                    picas++;
                }
            }
        }
        return picas;
    }
    public int calcularFijas(int[] numero){
       int fijas=0;
       for(int i =0;i<numero.Length;i++){
        if(numero[i]==this.numSecreto[i]){
            fijas++;
        }
       }
       return fijas;
    }
  public int getCantDigitos() {
    return cantDigitos;
  }

  public void setCantDigitos(int cantDigitos) {
    this.cantDigitos = cantDigitos;
  }
  public int getVidas() {
    return vidas;
  }

  public void setVidas(int vidas) {
    this.vidas = vidas;
  }

  public int getPuntaje() {
    return puntaje;
  }

  public void setPuntaje(int puntaje) {
    this.puntaje = puntaje;
  }

}