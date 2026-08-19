<?php

function executar(): void {
    echo "Vejo a previsão do tempo\n";
    echo "Está fazendo sol? (s/n)" . PHP_EOL;
    $estaFazendoSol = trim(fgets(STDIN));

    if (strtolower($estaFazendoSol) === 's') {
        echo "Vou à praia" . PHP_EOL;
    } else {
        echo "Vou estudar" . PHP_EOL;
    }

    echo "Almoçar" . PHP_EOL;
    echo "Ver televisão" . PHP_EOL;
    echo "Dormir" . PHP_EOL;
}

executar();