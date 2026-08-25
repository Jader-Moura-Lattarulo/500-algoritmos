def executar():
    print("Pegar faca, bacia e batatas.")
    print("Colocar água na bacia.")

    qtd_batatas = int(input("Quantas batatas você tem? "))

    todas_batatas = qtd_batatas
    batata_descascando = 1

    while qtd_batatas > 0:
        print(f"Descascando a {batata_descascando}ª batata.")

        qtd_batatas -= 1
        batata_descascando += 1

    batata_descascando -= 1

    print(f"Todas as {todas_batatas} foram descascadas.")

executar()