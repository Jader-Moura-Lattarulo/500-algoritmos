<?php

function executar(): void
{
    echo "Ler a prova." . PHP_EOL;

    echo "Quantas questões tem na prova? ";
    $numeroDeQuestoes = (int) trim(fgets(STDIN));

    $contadorDeQuestoes = 1;
    $tempoParaProva = 60;

    while ($numeroDeQuestoes > 0 && $tempoParaProva > 0) {

    echo "Você sabe responder a {$contadorDeQuestoes}ª questão? (s/n): ";
    $resposta = trim(fgets(STDIN));

    if (strtolower($resposta) === "s") {
        echo "Questão: {contadorDeQuestoes} respondida" . PHP_EOL;

        $tempoParaProva -= 3;

    } else {
        echo "Você pulou a questão: {$contadorDeQuestoes}" . PHP_EOL;

        $tempoParaProva -= 1;

    }

    $contadorDeQuestoes++;
    $numeroDeQuestoes--;
    }

    if ($tempoParaProva <= 0) {
        echo "O tempo acabou." . PHP_EOL;
        echo "Entregar a prova." . PHP_EOL;
    } elseif ($numeroDeQuestoes <= 0){
        echo "Você terminou a prova." . PHP_EOL;
        echo "Entregar a prova." . PHP_EOL;
    }
}

executar();