char[] torresHanoi = { 'A', 'B', 'C' };

int numeroDiscos = 3;

MoverTorres(torresHanoi[0], torresHanoi[2], torresHanoi[1], numeroDiscos);

static void MoverTorres(char torreIni,char torreFin, char torreTemp, int discos)
{
    if(discos > 0)
    {
        MoverTorres(torreIni, torreTemp, torreFin, discos - 1);
        Console.WriteLine($"Mover disco de {torreIni} a {torreFin}");
        MoverTorres(torreTemp, torreFin, torreIni, discos - 1);
    }
}