import { CardContainer } from "./style";

interface cardProps {
    image?: string,
    value?: number,
    description: string
}

const Card = (props: cardProps) => {
    return(
        <CardContainer>
            <img 
                style={{
                    height: '80%',
                    maxHeight: '150px',
                    padding: '10px',
                }}
                src={props.image}
                alt="Produto"
            />
            {props.description}
            <br/>
            <strong>
                R${props.value}
            </strong>
        </CardContainer>
    )
}

export {
    Card
};
export type { cardProps };
