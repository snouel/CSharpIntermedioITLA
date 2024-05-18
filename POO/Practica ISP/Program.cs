using Practica_ISP;

class Program
{
    static void Main()
    {
        IAveVoladora gorrionVolador = new Gorrion();
        IAveCantora gorrionCantor = new Gorrion();
        IAvePonedora gorrionPonedor = new Gorrion();

        gorrionVolador.Volar();
        gorrionCantor.Cantar();
        gorrionPonedor.PonerHuevos();

        IAveNadadora pinguinoNadador = new Pinguino();
        IAvePonedora pinguinoPonedor = new Pinguino();

        pinguinoNadador.Nadar();
        pinguinoPonedor.PonerHuevos();

        IAveVoladora aguilaVoladora = new Aguila();
        IAveCazadora aguilaCazadora = new Aguila();
        IAvePonedora aguilaPonedor = new Aguila();

        aguilaVoladora.Volar();
        aguilaCazadora.Cazar();
        aguilaPonedor.PonerHuevos();
    }