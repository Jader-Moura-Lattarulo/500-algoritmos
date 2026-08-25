<?php

function executar(): void
{
    echo "Digite a palavra escolhida: ";
    $palavra = strtolower(trim(fgets(STDIN)));

    $lacunasVazias = strlen($palavra);
    $partesCorpo = 0;
    $maximoPartesCorpo = 6;


    echo PHP_EOL;
    echo "Montar o diagrama do jogo." . PHP_EOL;

    while ($lacunasVazias > 0 && $partesCorpo < $maximoPartesCorpo) {

        echo "Digite uma letra: ";
        $letra = strtolower(trim(fgets(STDIN)));

        if (str_contains($palavra, $letra)) {
            echo "Acertou uma letra!" . PHP_EOL;

            $lacunasVazias--;
        } else {
            echo "Errou!" . PHP_EOL;

            $partesCorpo++;
        }

        echo "Lacunas vazias: {$lacunasVazias}" . PHP_EOL;

        echo "Partes do corpo: {$partesCorpo}/{$maximoPartesCorpo}" . PHP_EOL;

        echo PHP_EOL;
    }

    if ($lacunasVazias === 0) {
        echo "Parabéns! Você acertou a palavra." . PHP_EOL;
    } else {
        echo "Fim de jogo! O corpo foi completado na forca." . PHP_EOL;
    }
}

executar();
