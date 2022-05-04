

int imprimir (int veces) { 
    if (veces < 0) return 0;
if (veces > 0)

    Console.WriteLine("Se imprime la vez: " + veces);
    return imprimir(veces - 1);
}

imprimir(50);