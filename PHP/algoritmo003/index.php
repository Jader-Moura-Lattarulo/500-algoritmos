<?php

function executar(): void {
    echo "A lâmpada está fora de alcance? (s/n): ";
    $foraDeAlcance = trim(fgets(STDIN));

    if (strtolower($foraDeAlcance) === 's') {
        echo "Pegar a escada." . PHP_EOL;
    }

    echo "Pegar a lâmpada." . PHP_EOL;

    echo "A lâmpada está quente? (s/n): ";
    $quente = trim(fgets(STDIN));

    if (strtolower($quente) === 's') {
        echo "Pegar pano." . PHP_EOL;
    }

    echo "Tirar lâmpada queimada." . PHP_EOL;
    echo "Colocar lâmpada boa." . PHP_EOL;
}

executar();
