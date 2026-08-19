def executar():
    print("Pegar os ingredientes")

    roupa_branca = input(
        "Está de roupa branca? (s/n): "
    )

    if roupa_branca.lower() == "s":
        print("Colocar avental")

    tem_batedeira = input(
        "Tem batedeira? (s/n): "
    )

    if tem_batedeira.lower() == "s":
        print("Bater os ingredientes na batedeira")
    else:
        print("Bater os ingredientes à mão")

    print("Colocar a massa na forma")
    print("Colocar a forma no forno")
    print("Aguardar o tempo necessário")
    print("retirar o bolo")

executar()