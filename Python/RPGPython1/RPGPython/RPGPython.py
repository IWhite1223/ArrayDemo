#Iesha White
#function showing the goal of the game and move commands
def show_instructions():
    # print a main menu and the commands
    print("Tombs of Milore Adventure Game")
    print("Collect 6 items to win the game, or be defeated by the Guardian of Milore.")
    print("Move commands: go South, go North, go East, go West")
    print("Add to Inventory: get 'item name'\n")


#Introduction of room and item
def show_status(current_room):
    print("\nYou are currently in {}".format(current_room))

    item = 'None'
    if 'item' in rooms[current_room]:
        item = rooms[current_room]['item']
    print('Item in this room:', item)
    print("Inventory:", inventory)   
    print("-----------------------------------")


# A dictionary for the simplified Tombs of Milore text game
# The dictionary links a room to other rooms and the items as keys in the room.
rooms = {
    'Entry to the Ruins': {'South': 'Tomb of Thieves', 'East': 'Blessed Grounds'},
    'Tomb of Thieves': {'North': 'Entry to the Ruins', 'East': 'Armory', 'West': 'Serpents Hall',
                        'South': 'Apothecary', 'item': 'sword'},
    'Blessed Grounds': {'West': 'Entry to the Ruins', 'item': 'the torch'},
    'Serpents Hall': {'East': 'Tomb of Thieves', 'item': 'skin of a milorian beast'},
    'Armory': {'West': 'Tomb of Thieves', 'North': 'The Guardian of Milore',
               'item': 'armor'},
    'Apothecary': {'North': 'Tomb of Thieves', 'East': 'Fools Gold',
                   'item': 'the strength potion'},
    'Fools Gold': {'West': 'Apothecary', 'item': 'iron shield'},
    'The Guardian of Milore': {'South': 'Armory'},
}

# State what is in the inventory
inventory = []

#naigation between rooms
def update_room(action, move, current_room):
    if action == 'Go':
        if move in rooms[current_room]:
            return rooms[current_room][move]
        else:
            print("\nInvalid Move. There's no room {} of here".format(move)) #if player tries to go in a direction that isn't allowed
    elif action == 'Get':
        item_name = move
        if rooms[current_room]['item'].lower() == item_name.lower():
            inventory.append(item_name)
            rooms[current_room].pop('item')
            # check for end game
            if len(inventory) == 6:
                print('You collected all the items.')

        elif len(inventory) == 0:
             print("\nThis item is not in this ruin") #if they try to collect an incorrect item
            


# Let's start from the Entry to the Ruins
starting_room = 'Entry to the Ruins'

# Current room to use in the gameplay loop
current_room: str = starting_room

show_instructions()

while True:
    show_status(current_room)

    action, *moves = input(
        'Enter \'go North/South/East/West\' to move or \'exit\'\n'
        'Collect the item in the room by typing get item name: \n\n').split()

    move = ' \n'.join(moves)

    action = action.capitalize()

    move = move.capitalize()


    next_room = update_room(action, move, current_room)

    if next_room is not None:
        current_room = next_room

    if current_room == 'The Guardian of Milore': #final room with boss
        # check number of items
        print('You reached the final room')
        if len(inventory) == 6:
            print('You win!')
        else:
            print('You lose!')
        break  # end game

    # user to exit
    if move == 'Exit':
        current_room = 'exit'
        break
