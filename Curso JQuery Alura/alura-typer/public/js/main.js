// Retornando o texto do classe frase do meu HTML
var frase = $(".frase").text();
// Separa todas as palavras da frase por expaços e mostra o tamanho total
var numPalavras = frase.split(" ").length;
//encontra o conteudo que eu quero pela id e . text retorna o valor da quantidade
var tamanhoDaFrase = $("#tamanho-frase").text(numPalavras);




