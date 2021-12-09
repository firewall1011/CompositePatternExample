# Padrão Composto (_Composite_)

Códigos em _C#_ com exemplos do padrão Composto (_Composite_).

## Classe CompoundGraphicElement

O arquivo `src/CompoundGraphicElement.cs` implementa um exemplo de uso do padrão composto para uma hierarquia de elementos gráficos.
Estes elementos podem ser únicos ou compostos por outros elementos e ao desenhar (função _Draw_) um elemento, deve-se desenhar os seus elementos filhos.

A interface `IGraphicElement` representa um elemento gráfico, que seria um nó da hierarquia do objeto composto.

A implementação concreta `CompoundGraphicElement` representa um contêiner de elementos gráficos, o qual desenha somente seus filhos.

A pasta `src/Shapes` possui implementações concretas de elementos gráficos que herdam de `CompoundGraphicElement`. Estas implementações desenham a si mesmas e seus filhos.
Uma exceção à essa regra é o arquivo `Leaf.cs`, o qual possui a classe `Leaf` que implementa a interface `IGraphicElement` somente e, portanto, não possui filhos.

## Classe Transform

O arquivo `src/Transform.cs` possui a classe `Transform`, a qual representa a posição, rotação e escala de um objeto.
Esta classe possui uma hierarquia de árvore e é usada pelo IGraphicElement para que os elementos gráficos sejam desenhados de forma relativa aos seus elementos pais.\
Esse comportamento é exemplificado no arquivo `src/Program.cs`, o qual possui um exemplo de uso do padrão Composto.
Neste exemplo, cria-se uma "pessoa" com cabeça, orelhas, braços, mãos e dedos e utiliza-se da hierarquia para posicionar os objetos e fazer com que a rotação de um deles afete os outros.
Por exemplo: ao se rotacionar o objeto que representa a cabeça (_head_), as orelhas também são rotacionadas.
