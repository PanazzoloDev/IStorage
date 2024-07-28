const currencyConverter = (
    value?: number,
    locale: string = 'pt-BR',
    currency: string = 'BRL'
): string => {
    if(value === undefined) {return ''}
    return new Intl.NumberFormat(locale, {
      style: 'currency',
      currency: currency,
    }).format(value);
  };

export default currencyConverter