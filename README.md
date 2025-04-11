<h1>Unity_RayCastEx</h1>
<p>Exemplo de Raycast, feito no Unity</p><br>
<p>No Unity, criamos uma cena para fazer o teste do Raycast.</p>
<p>Na criação do cenario, para a realização dos testes, utilizamos 4 GameObjects Plane (4 objetos planos) com material tranparente. Também baixamos um asset, da Asset Store, para fazer o fundo da cena. Adicionamos particulas de estrelas, e mudamos a luz direcional.</p>

![Imagem: Cena](https://github.com/user-attachments/assets/b20dc269-a8b5-4af8-8865-ed2042b0022c)
<p>No centro da cena, colocamos um cubo, que iremos utilizar mais adiante para disparar o raycast, e uma esfera verde para ser o alvo.</p>
<br>
<h2>No código criamos 3 funções para disparar o raycast.</h2>
<p>O primeiro é ativado através do click do botão esquerdo do mouse. Ele "atira" o raycast, da cor do material "cheary", a partir da posição do mouse na tela.</p>
<p>Você pode observar o resultado abaixo.</p>

![Imagem: Click Mouse Raycast](https://github.com/user-attachments/assets/3ff82d9c-da7a-49e8-b53d-37ed1d40bbd7)
<br><br>
<p>O segundo é ativado precionando a tecla "E". Ele dispara o raycast, da cor do material "white", a partir do centro do objeto cubo, que é um prefab da cena.</p>
<p>Você pode observar o resultado abaixo.</p>

![Imagem: Click "E" Raycast](https://github.com/user-attachments/assets/6d7b49f0-ddef-408a-bc07-aae8863c7c1f)
<br><br>
<p>E o ultimo, é ativado precionando a tecla "Q", do teclado. Ele "atira" o raycast, da cor do material "blue", a partir do centro da camera.</p>
<p>Você pode observar o resultado abaixo.</p>

![Imagem: Click "Q" Raycast](https://github.com/user-attachments/assets/f170478e-306a-4e44-8814-422eb53985ee)
<br><br>
<h2>Todas essas funções são decorentes do método "Atirar", que é responsavel por definir a origem e a direção do raio, e também ver se ele está colidindo com algo.</h2>

![Imagem: Método Atirar](https://github.com/user-attachments/assets/5263e50a-60fd-4cd1-b87a-319c5c898af0)
<br><br>
<h2>Agora, acompanhe o vídeo mostrando as funções do raycast.</h2>

https://github.com/user-attachments/assets/78b6ae75-c4af-428c-bf7d-78ee0b3dd62d
