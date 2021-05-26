#include <SFML/Graphics.hpp>
int main() {
sf::RenderWindow window{ { 800, 800 }, "Untitled_GaMe" }; window.setFramerateLimit(60);
    while (window.isOpen())
    {
sf::Event event;
while (window.pollEvent(event)) {
            if (event.type == sf::Event::Closed)
            {
window.close(); }
}
        window.clear();
        window.display();
        sf::Font font;
if (!font.loadFromFile("DejaVuSans.ttf")) {
return -1; }
sf::Text meeting_cpp{ "Hi! Welcome to Untitled_GaMe!", font, 30 };
meeting_cpp.setPosition({ 0.f, 0.f });
meeting_cpp.setStyle(sf::Text::Bold);
meeting_cpp.rotate(0.f);
window.clear();
window.draw(Untitled_GaMe);
window.display();
  
    }
}
