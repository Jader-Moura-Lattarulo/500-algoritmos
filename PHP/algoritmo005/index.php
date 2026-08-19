<?php

function executar(): void {
    echo "Pegar os ingreditens" . PHP_EOL;
    echo "Está de roupa branca? (s/n): ";
    $roupaBranca = trim(fgets(STDIN));

    if (strtolower($roupaBranca) === 's') {
        echo "Colocar o avental" . PHP_EOL;
    }

    echo "Tem batedeira? (s/n): ";
    $temBatedeira = trim(fgets(STDIN));

    if (strtolower($temBatedeira) === 's') {
        echo "Bater os ingredientes na batedeira" . PHP_EOL;   
    } else {
        echo "Bater os ingredientes à mão" . PHP_EOL;
    }

    echo "Colocar a massa na forma" . PHP_EOL;
    echo "Colocar a forma no forno" . PHP_EOL;
    echo "Aguardar o tempo necessário" . PHP_EOL;
    echo "Retirar o bolo" . PHP_EOL;
}

executar();