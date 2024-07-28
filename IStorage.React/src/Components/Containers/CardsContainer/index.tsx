import { CardsContainerStyled } from "./style";

const CardsContainer = ({...props}) =>{
    return(
        <CardsContainerStyled>
            {props.children}
        </CardsContainerStyled>
    )
}

export default CardsContainer;