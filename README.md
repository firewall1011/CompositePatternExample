# Padr�o Composto (_Composite_)

C�digos em _C#_ com exemplos do padr�o Composto (_Composite_).

## Classe CompoundGraphicElement

O arquivo `src/CompoundGraphicElement.cs` implementa um exemplo de uso do padr�o composto para uma hierarquia de elementos gr�ficos.
Estes elementos podem ser �nicos ou compostos por outros elementos e ao desenhar (fun��o _Draw_) um elemento, deve-se desenhar os seus elementos filhos.

A interface `IGraphicElement` representa um elemento gr�fico, que seria um n� da hierarquia do objeto composto.

A implementa��o concreta `CompoundGraphicElement` representa um cont�iner de elementos gr�ficos, o qual desenha somente seus filhos.

A pasta `src/Shapes` possui implementa��es concretas de elementos gr�ficos que herdam de `CompoundGraphicElement`. Estas implementa��es desenham a si mesmas e seus filhos.
Uma exce��o � essa regra � o arquivo `Leaf.cs`, o qual possui a classe `Leaf` que implementa a interface `IGraphicElement` somente e, portanto, n�o possui filhos.

## Classe Transform

O arquivo `src/Transform.cs` possui a classe `Transform`, a qual representa a posi��o, rota��o e escala de um objeto.
Esta classe possui uma hierarquia de �rvore e � usada pelo IGraphicElement para que os elementos gr�ficos sejam desenhados de forma relativa aos seus elementos pais.\
Esse comportamento � exemplificado no arquivo `src/Program.cs`, o qual possui um exemplo de uso do padr�o Composto.
Neste exemplo, cria-se uma "pessoa" com cabe�a, orelhas, bra�os, m�os e dedos e utiliza-se da hierarquia para posicionar os objetos e fazer com que a rota��o de um deles afete os outros.
Por exemplo: ao se rotacionar o objeto que representa a cabe�a (_head_), as orelhas tamb�m s�o rotacionadas.
