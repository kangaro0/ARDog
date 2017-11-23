//
// Created by kanga on 18.11.2017.
//

#include <sstream>

#include "tango_event_data.h"

namespace ARDog {
    TangoEventData::TangoEventData() {}
    TangoEventData::~TangoEventData() {}

    void TangoEventData::UpdateTangoEvent(const TangoEvent *event) {
        std::stringstream string_stream;
        string_stream << event->event_key << ": " << event->event_value;
        event_string_ = string_stream.str();
        string_stream.flush();
    }

    void TangoEventData::ClearEventString() {
        event_string_.clear();
    }

    std::string TangoEventData::GetTangoEventString() {
        return event_string_;
    }
}
