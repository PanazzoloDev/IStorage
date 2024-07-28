import { useState } from "react";
import { FilterPanelContainer } from "./style";

const FilterPanel = () => {
    const [opened, setOpened] = useState<boolean>(false)

    const onChangeFilterPanel = () => {
        setOpened(!opened)
    }

    return(
        <FilterPanelContainer
            open={opened}
        >
            <button children="==" onClick={onChangeFilterPanel}/>
            ○testeTESTEW
        </FilterPanelContainer>
    )
}

export default FilterPanel;