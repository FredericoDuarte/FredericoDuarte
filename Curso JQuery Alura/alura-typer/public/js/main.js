// Retornando o texto do classe frase do meu HTML
var frase = $(".frase").text();
// Separa todas as palavras da frase por expaços e mostra o tamanho total
var numPalavras = frase.split(" ").length;
//encontra o conteudo que eu quero pela id e . text retorna o valor da quantidade
var tamanhoDaFrase = $("#tamanho-frase").text(numPalavras);

// Selecionando o campo de digitacao pela sua id HTML
var campo = $(".campo-digitacao");
//Função para escutar o evento no caso o clique do mouse
campo.on("input", function(){
    var conteudo = campo.val();

    var qtdPalavras = conteudo.split(/\S+/).length - 1; // (/\S+/) significa para procurar todos os espaços vazios
    $("#contador-palavras").text(qtdPalavras);

    var qrdCaracteres = conteudo.length;
    $("#contador-caracteres").text(qrdCaracteres);
});


