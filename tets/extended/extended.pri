include(./super/super.pri)
HEADERS += \
        $$PWD/extended.h
SOURCES += \
        $$PWD/extended.cpp


ORTOOLS_PATH = $$PWD/or-tools/
INCLUDEPATH += $${ORTOOLS_PATH}/include
LIBS += -L$${ORTOOLS_PATH}/lib -lCbc -lglog -lgflags -lCbcSolver -lCbc -lOsiCbc -lCgl -lClpSolver -lClp -lOsiClp -lOsi -lCoinUtils -lortools -lz -lrt -lpthread
