def executar():
    print("Vejo a previsão do tempo")

    fazendo_sol = input(
        "Está fazendo sol? (s/n): "
    )

    if fazendo_sol.lower() == "s":
        print("Vou à praia")
    else: 
        print("Vou estudar")

    print("Almoçar")
    print("Ver televisão")
    print("dormir")

executar()