package main.java.com.model;

import java.math.BigDecimal;
import java.util.HashMap;
import java.util.Map;

public class Currency {

    private String currencyName;
    private String currencyCode;
    private Map<String, BigDecimal> conversionRates = new HashMap<String, BigDecimal>();

    public Currency(String currencyName, String currencyCode, Map<String, BigDecimal> conversionRates) {
        this.currencyName = currencyName;
        this.currencyCode = currencyCode;
        this.conversionRates = conversionRates;
    }

    public Currency(){}

    public String getCurrencyName() {
        return currencyName;
    }

    public void setCurrencyName(String currencyName) {
        this.currencyName = currencyName;
    }

    public String getCurrencyCode() {
        return currencyCode;
    }

    public void setCurrencyCode(String currencyCode) {
        this.currencyCode = currencyCode;
    }

    public Map<String, BigDecimal> getConversionRates() {
        return conversionRates;
    }

    public void setConversionRates(Map<String, BigDecimal> conversionRates) {
        this.conversionRates = conversionRates;
    }
}
