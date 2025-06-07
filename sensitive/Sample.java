package com.example;

/**
 * Sample class to test keyword/param scanning.
 */
public class Sample {

    // ─────────────────────────────────────────────────────────────
    // 1)  keyword YES, param YES   →  "keyword yes param yes"
    public void processDog(String catAmount) {
        // the keyword "dog" appears here
        int countDog = 0;
        if (catAmount != null) {
            countDog++;
        }
    }
    }
}
