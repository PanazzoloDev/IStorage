import { Card, cardProps } from "../../Components/Card";
import CardsContainer from "../../Components/Containers/CardsContainer";
import FilterPanel from "../../Components/Containers/FilterPanel";
import Screen from "../../Components/Containers/Screen";

const testData = Array<cardProps>(
    {image: 'https://upload.wikimedia.org/wikipedia/commons/f/fd/Brazilian_pastel.jpg', value: 10.90, oldValue: 16.20, description:'Pastel'},
    {image: 'https://upload.wikimedia.org/wikipedia/commons/f/fd/Brazilian_pastel.jpg', value: 10.90, description:'Pastel'},
    {image: 'https://www.minhareceita.com.br/app/uploads/2022/12/Dpizza-de-pepperoni-caseira-portal-minha-receita.jpg', value: 29.90, oldValue: 16.20, description:'Pizza'},
    {image: 'https://www.minhareceita.com.br/app/uploads/2022/12/Dpizza-de-pepperoni-caseira-portal-minha-receita.jpg', value: 29.90, description:'Pizza'},
    {image: 'https://www.minhareceita.com.br/app/uploads/2022/12/Dpizza-de-pepperoni-caseira-portal-minha-receita.jpg', value: 29.90, description:'Pizza'},
    {image: 'https://upload.wikimedia.org/wikipedia/commons/thumb/4/45/A_small_cup_of_coffee.JPG/1280px-A_small_cup_of_coffee.JPG', value: 25.00, description:'Café'},
    {image: 'https://upload.wikimedia.org/wikipedia/commons/thumb/4/45/A_small_cup_of_coffee.JPG/1280px-A_small_cup_of_coffee.JPG', value: 25.00, description:'Café'},
    {image: 'https://upload.wikimedia.org/wikipedia/commons/thumb/4/45/A_small_cup_of_coffee.JPG/1280px-A_small_cup_of_coffee.JPG', value: 25.00, description:'Café'},
    {image: 'https://www.bongusto.ind.br/wp-content/uploads/2023/06/FRAPE-CAPUCCINO14.jpg', value: 19.90, description:'Capuccino'},
    {image: 'https://www.bongusto.ind.br/wp-content/uploads/2023/06/FRAPE-CAPUCCINO14.jpg', value: 19.90, description:'Capuccino'},
    {image: 'https://www.tendaatacado.com.br/dicas/wp-content/uploads/2022/06/como-fazer-batata-frita-topo.jpg', value: 30.90, description:'Fritas'},
    {image: 'https://www.tendaatacado.com.br/dicas/wp-content/uploads/2022/06/como-fazer-batata-frita-topo.jpg', value: 30.90, description:'Fritas'},
    {image: 'https://www.tendaatacado.com.br/dicas/wp-content/uploads/2022/06/como-fazer-batata-frita-topo.jpg', value: 30.90, description:'Fritas'}
)

const MainScreen = () => {
    return (
        <Screen>
            <FilterPanel/>
            <CardsContainer>
                {testData.map((x, i) => 
                    <Card
                        key={i}
                        value={x.value}
                        oldValue={x.oldValue}
                        image={x.image}
                        description={x.description}
                    />
                )}
            </CardsContainer>
        </Screen>
    )
}

export default MainScreen;

