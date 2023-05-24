import pygame
import time
import sys

# initialize Pygame
pygame.init()

# set the screen size
screen = pygame.display.set_mode((0, 0), pygame.FULLSCREEN)

# load the first image
image1 = pygame.image.load('image1.jpg')

# load the second image
image2 = pygame.image.load('image2.jpg')

# set the initial image
current_image = image1

# set the timer to lock the screen after 5 seconds
timer = 5

# start the game loop
while True:
    # handle events
    for event in pygame.event.get():
        # if the mouse moves, change the current image
        if event.type == pygame.MOUSEMOTION:
            current_image = image2
        # if the user clicks the close button or presses the escape key, exit the program
        if event.type == pygame.QUIT or (event.type == pygame.KEYDOWN and event.key == pygame.K_ESCAPE):
            pygame.quit()
            sys.exit()

    # draw the current image on the screen
    screen.blit(current_image, (0, 0))

    # update the screen
    pygame.display.update()

    # decrement the timer
    timer -= 1

    # if the timer reaches 0, lock the screen and exit the program
    if timer == 0:
        # call the appropriate system function to lock the screen
        # ...

        # exit the program
        pygame.quit()
        sys.exit()
