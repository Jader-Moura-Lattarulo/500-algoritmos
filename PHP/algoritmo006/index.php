<?php

function executar(): void
{
    echo "Pegar faca, bacia e batatas." . PHP_EOL;
    echo "Colocar água na bacia." . PHP_EOL;

    echo "Quantas batatas você tem? ";
    $qtdBatatas = (int) trim(fgets(STDIN));

    $todasBatatas = $qtdBatatas;
    $batataDescascando = 1;

    while ($qtdBatatas > 0) {
        echo "Descascando a {$batataDescascando}ª batata." . PHP_EOL;

        $qtdBatatas--;
        $batataDescascando++;
    }

    $batataDescascando--;

    echo "Todas as {$todasBatatas} foram descascadas" . PHP_EOL;
}

executar();