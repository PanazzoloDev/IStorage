import currencyConverter from "../CurrencyConverter";
import { CardContainer, CardImage, CardValue, CardValues } from "./style";

interface cardProps {
    image?: string,
    value: number,
    oldValue?: number,
    description: string
}

const Card = (props: cardProps) => {

    return(
        <CardContainer>
            <CardImage 
                src={props.image}
                alt="Produto"
            />
            {props.description}
            <CardValues>
                <span style={{padding: '0px 10px'}}>
                    <s>
                        {currencyConverter(props.oldValue)}
                    </s>
                </span>
                <CardValue discount={props.oldValue != undefined}>
                    {currencyConverter(props.value)}
                </CardValue>
            </CardValues>
        </CardContainer>
    )
}

export {
    Card
};
export type { cardProps };
