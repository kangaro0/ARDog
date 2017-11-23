//
// Created by kanga on 18.11.2017.
//

#ifndef ARDOG_TANGO_EVENT_DATA_H
#define ARDOG_TANGO_EVENT_DATA_H

#include <jni.h>
#include <mutex>
#include <string>

#include <tango_client_api.h>

namespace ARDog {

    class TangoEventData {
    public:
        TangoEventData();
        ~TangoEventData();

        void UpdateTangoEvent( const TangoEvent* event );
        void ClearEventString();
        std::string GetTangoEventString();

    private:
        std::string event_string_;
    };
}

#endif //ARDOG_TANGO_EVENT_DATA_H
