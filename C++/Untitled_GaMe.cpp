#include <QApplication>
#include <QWidget>

int main(int argc, char *argv[]) {
    
    QApplication app(argc, argv);

    QWidget window;

    window.resize(640, 480);
    window.setWindowTitle("Untitled_GaMe");
    window.setText("Hello! Welcome to Untitled_GaMe!");
    window.show();

    return app.exec();
}
