package main.java.com.model;

import java.math.BigDecimal;

public class Currency {

    private String originalCurrency;
    private String targetCurrency;
    private BigDecimal conversionRate;

    public Currency(String originalCurrency, String targetCurrency, BigDecimal conversionRate) {
        this.originalCurrency = originalCurrency;
        this.targetCurrency = targetCurrency;
        this.conversionRate = conversionRate;
    }

    public String getOriginalCurrency() {
        return originalCurrency;
    }

    public void setOriginalCurrency(String originalCurrency) {
        this.originalCurrency = originalCurrency;
    }

    public String getTargetCurrency() {
        return targetCurrency;
    }

    public void setTargetCurrency(String targetCurrency) {
        this.targetCurrency = targetCurrency;
    }

    public BigDecimal getConversionRate() {
        return conversionRate;
    }

    public void setConversionRate(BigDecimal conversionRate) {
        this.conversionRate = conversionRate;
    }
}
