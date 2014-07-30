rm -r build
mkdir build
i686-elf-as src/boot.s -o build/boot.o
echo "Built bootstrap"
i686-elf-gcc -c src/kernel.c -o build/kernel.o -std=gnu99 -ffreestanding -O2 -Wall -Wextra
echo "Built kernel"
i686-elf-gcc -T linker.ld -o myos.bin -ffreestanding -O2 -nostdlib build/boot.o build/kernel.o
echo "Linked."
echo "Done"
