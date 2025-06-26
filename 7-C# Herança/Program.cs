/*class Program
{
    static void Main()
    {
        ClienteVip cliente1 = new ClienteVip("Renata", 32, "Ouro", "VIP123A");

        ClienteVip cliente2 = new ClienteVip("Leonardo", 40, "Diamante", "VIP789X");

        cliente1.ExibirInfo();
        cliente2.ExibirInfo();
    }
}*/

//2:
/*class Program
{
    static void Main()
    {
        Interno f1 = new Interno("Luciana", "Desenvolvedora", 7000.00m);
        Freelancer f2 = new Freelancer("Carlos", "Designer", 3500.00m);

        f1.ExibirInformacoes();
        f2.ExibirInformacoes();
    }
}*/

//3
/*class Program
{
    static void Main()
    {
        Passageiro p1 = new Passageiro("Lúcia", 45, 3);
        Passageiro p2 = new Passageiro("Rodrigo", 30, 1);

        p1.ExibirInformacoes();
        p2.ExibirInformacoes();
    }
}*/

//4
/*class Program
{
    static void Main()
    {
        Analista analista = new Analista("Analista de Sistemas");
        Docente docente = new Docente("Docente de Matemática");

        Certificado cerf1 = new Certificado(analista); 
        Certificado certf2 = new Certificado(docente);
    }
}*/

//5
/*class Program
{
    static void Main()
    {
        Pergaminho pergaminhoAntigo = new Pergaminho(
            "Segredos_Antigos.txt", "A chave para a sabedoria reside na observação...");

        pergaminhoAntigo.MostrarDetalhes();
    }
}*/

//6
/*class Program
{
    static void Main()
    {
        SensorTemperatura temp = new SensorTemperatura();
        SensorPresenca presenca = new SensorPresenca();

        temp.Ativar();
        temp.Desativar();

        presenca.Ativar();
        presenca.Desativar();
    }
}*/

//7
/*class Program
{
    static void Main()
    {
        Processador cpu = new Processador("Intel", "i7-12700K");
        PlacaMae mobo = new PlacaMae("ASUS", "LGA1700");
        Computador pc = new Computador(cpu, mobo);

        pc.ExibirConfiguracao();
    }
}*/

//8
/*class Program
{
    static void Main()
    {
        PagamentoCredito cliente1 = new PagamentoCredito("André", "andre@email.com");
        PagamentoBoleto cliente2 = new PagamentoBoleto("Juliana", "juliana@email.com");

        cliente1.ProcessarPagamento();
        cliente2.ProcessarPagamento();
    }
}*/

//9:
/*class Program
{
    static void Main()
    {
        Funcionario tecnico = new Funcionario("João", "TI");
        IServico s1 = new Manutencao("Atualização de servidor", tecnico);

        Funcionario analista = new Funcionario("Marina", "Consultoria");
        IServico s2 = new Consultoria("Planejamento estratégico", analista);

        s1.ExecutarServico();
        s2.ExecutarServico();
    }
}*/

//10:
class Program
{
    static void Main()
    {
        Instrutor instrutor1 = new Instrutor("Carla", "Back-end");
        ICurso curso1 = new CursoProgramacao("C# com POO", instrutor1);
        
        Instrutor instrutor2 = new Instrutor("Felipe", "UI/UX");
        ICurso curso2 = new CursoDesign("Design de Interfaces", instrutor2);
        
        curso1.ValidarConteudo();
        curso1.PublicarCurso();
        
        curso2.ValidarConteudo();
        curso2.PublicarCurso();
    }
}
