def executar():
    fora_de_alcance = input(
        "A lâmpada está fora de alcance? (s/n): "
    )

    if fora_de_alcance.lower() == "s":
        print("Pegar a escada.") 

    print("Pegar a lâmpada.")

    quente = input(
        "A lâmpada está quente? (s/n): "
    )

    if quente.lower() == 's':
        print("Pegar pano.")

    print("Tirar lâmpada queimada.")
    print("Colocar lâmpada boa.")

executar()