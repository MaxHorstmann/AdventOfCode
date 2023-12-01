package main

import (
	"bufio"
	"fmt"
	"log"
	"os"
	"strconv"
)

func getResult(input string) int {
	var first int
	var last int
	firstFound := false

	for _, ch := range input {
		i, err := strconv.Atoi(string(ch))
		if err == nil {
			if !firstFound {
				first = i
				firstFound = true
			}
			last = i
		}
	}

	return 10*first + last
}

func main() {
	const inputFile = "input.txt"

	file, err := os.Open(inputFile)
	if err != nil {
		log.Fatal(err)
	}
	defer file.Close()

	scanner := bufio.NewScanner(file)
	sum := 0
	for scanner.Scan() {
		sum += getResult(scanner.Text())
	}

	fmt.Println(sum)

	if err := scanner.Err(); err != nil {
		log.Fatal(err)
	}
}
